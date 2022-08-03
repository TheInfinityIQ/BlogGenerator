<script setup lang="ts">
import client from "@/api";
import type { BlogsResponse, BlogResponse } from "@/models";
import { ref } from "@vue/reactivity";
import { onMounted } from "vue";
import Blog from "../components/Blog.vue";
import Modal from "../components/Modal.vue";

let blogs = ref<BlogResponse[]>([]);

onMounted(async () => {
    const blogsResponse = await client.GetAllBlogs();
    blogs.value = blogsResponse.blogs;
});

const deleteById = (id: number) => {
    client.DeleteBlog(id);
    blogs.value = blogs.value.filter(blog => blog.id != id);
}

const isUpdating = (id: number, title: string, content: string) => {
    client.UpdateBlog();
}
</script>

<template>
<!-- Container needs to wrap modal or it will make blogs off center -->
    <ul class="blogs-container">
    <Modal title="Test" content="Test" class="z-1" v-show="true"/>
        <li v-for="blog in blogs" :key="blog.id">
            <Blog :title="blog.title" :content="blog.content" :id="blog.id" class="blog" @isDeleted="deleteById" />
        </li>
    </ul>
</template>

<style scoped>
.z-1 {
    z-index: 1;
}

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

    z-index: auto;
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
