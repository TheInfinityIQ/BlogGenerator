<script setup lang="ts">
import client from "@/api";
import type { BlogsResponse } from "@/models";
import Blog from "../components/Blog.vue";

const blogsResponse: BlogsResponse = await client.GetAllBlogs();
</script>

<template>
    <ul class="blogs-container">
        <li v-for="blog in blogsResponse.blogs">
            <Blog :title="blog.title" :content="blog.content" class="blog" />
        </li>
    </ul>
</template>

<style scoped>

.blogs-container {
    display: flex;
    align-items: center;
    flex-direction: column;
    flex-flow: row;
    flex-wrap: wrap;
    gap: 5em;

    min-height: 86vh;
    width: 100vw;
    overflow-y: scroll;

    padding: 0;
    margin: 0;
}

.blog {
    margin: 2em 0;
    width: 25vw;
}

li {
  list-style-type: none;

  display: flex;
  justify-content: center;
}

</style>
