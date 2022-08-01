<script setup lang="ts">
import type { BlogsResponse, BlogResponse, Blog } from "@/models";
import client from "../api";

const { title, content } = defineProps<{
    title: string;
    content: string;
}>();
</script>

<template>
    <div class="blog-container">
        <h2>{{ title }}</h2>
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
</style>
