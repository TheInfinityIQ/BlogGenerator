<script setup lang="ts">
import type { BlogsResponse, BlogResponse, Blog } from "@/models";
import client from "../api";

const { title, content } = defineProps<{
    title: string;
    content: string;
}>();

// let thing: BlogResponse = await client.GetBlog(3);
// console.log(thing);

// let thing: Response = await client.DeleteBlog(1);
// console.log(thing);

let updatedBlog: Blog = {
    id: 0,
    title: "this is my updated blog title",
    content: "this is the content of the blog"
}
let thing: Response = await client.UpdateBlog(1, updatedBlog);
</script>

<template>
    <div class="blog-container">
        <h3>{{ title }}</h3>
        <p>{{ content }}</p>
        <!-- <h3>{{ getTestBlog.title }}</h3>
                <p>{{ getTestBlog.content }}</p> -->
    </div>
</template>

<style scoped>
.blog-container {
    width: 50%;
    min-width: 350px;
    max-width: 500px;

    height: 15vh;
    min-height: 200px;

    border: 1px solid black;
    border-radius: 15px;

    padding: 2em;

    overflow-y: auto;
}

h3 {
}

p {
}
</style>
