import type { Blog, BlogResponse, BlogsResponse } from "./models";

const enum HttpMethods {
    GET = "GET",
    POST = "POST",
    PUT = "PUT",
    DELETE = "DELETE",
}

class BaseApi {
    private _path: string = "https://localhost:7240";

    public async SendGETRequestAsync(uri: string, headers?: HeadersInit): Promise<Response> {
        return this.SendRequestAsync(uri, undefined, HttpMethods.GET, headers);
    }

    public async SendPOSTRequestAsync(uri: string, body: object, headers?: HeadersInit): Promise<Response> {
        return this.SendRequestAsync(uri, body, HttpMethods.POST, headers);
    }

    public async SendPUTRequestAsync(uri: string, body: object, headers?: HeadersInit): Promise<Response> {
        return this.SendRequestAsync(uri, body, HttpMethods.PUT, headers);
    }

    public async SendDELETERequestAsync(uri: string, headers?: HeadersInit): Promise<Response> {
        return this.SendRequestAsync(uri, undefined, HttpMethods.DELETE, headers);
    }

    public async SendRequestAsync(uri: string, body?: object, method?: HttpMethods, headers?: HeadersInit): Promise<Response> {
        try {
            const isBodyHere: Boolean = !!body;
            const myMethod: HttpMethods = method ?? HttpMethods.POST;
            const myHeaders: HeadersInit = isBodyHere ? { "Content-Type": "application/json", ...headers } : { ...headers };
            const myBody: BodyInit | undefined = isBodyHere ? JSON.stringify(body) : undefined;

            const response = await fetch(`${this._path}/${uri}`, {
                method: myMethod,
                headers: myHeaders,
                body: myBody,
            });

            if (!response?.ok) {
                throw new Error(`[${response.status}] response not ok`);
            }

            return response;
        } catch (error) {
            console.log("API EXCEPTION:", error);
            throw error;
        }
    }
}

class Api extends BaseApi {
    constructor() {
        super();
    }

    public async GetAllBlogs(): Promise<BlogsResponse> {
        const uri: string = "blog";
        let response: Response = await this.SendGETRequestAsync(uri);
        let jsonResponse: BlogsResponse = await response.json();

        return jsonResponse;
    }

    public async GetBlog(id: number): Promise<BlogResponse> {
        const uri: string = `blog/${id}`;
        let response: Response = await this.SendGETRequestAsync(uri);
        let jsonResponse: BlogResponse = await response.json();

        return jsonResponse;
    }

    public async DeleteBlog(id: number): Promise<Response> {
        const uri: string = `blog/${id}`;
        let response: Response = await this.SendDELETERequestAsync(uri);

        return response;
    }

    public async UpdateBlog(id: number, blog: Blog): Promise<Response> {
        const uri: string = `blog/${id}`;
        blog.id = id; // Ensures ID matches when updating blog in backend
        let response = await client.SendPUTRequestAsync(uri, blog);

        return response;
    }

    public async AddBlog(blog: Blog): Promise<Response> {
        const uri: string = "blog";
        let response: Response = await client.SendPOSTRequestAsync(uri, blog);

        return response;
    }
}

let client = new Api();
export default client;
