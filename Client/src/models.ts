export type BlogsResponse = {
    blogs: {
        id: number;
        title: string;
        content: string;
    }[];
};

export type BlogResponse = {
    id: number;
    title: string;
    content: string;
};

export type GeneratorResponse = {
    numBlog: number;
    numWords: number;
    numSentences: number;
};

export type Blog = {
    id: number;
    title: string;
    content: string;
};
