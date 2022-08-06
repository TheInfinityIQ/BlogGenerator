<script setup lang="ts">
import client from "@/api";
import type { BlogsResponse, BlogResponse } from "@/models";
import { ref, reactive } from "@vue/reactivity";
import { onMounted } from "vue";
import Blog from "../components/Blog.vue";
import Modal from "../components/Modal.vue";

let blogs = ref<BlogResponse[]>([]);

let isUpdating = ref<boolean>(false);
let updatedBlog: BlogResponse = {
    id: 0,
    title: "",
    content: "",
};

let initModalTitle = ref("");
let initModalContent = ref("");

onMounted(async () => {
    const blogsResponse = await client.GetAllBlogs();
    blogs.value = blogsResponse.blogs;
});

const deleteById = (id: number) => {
    client.DeleteBlog(id);
    blogs.value = blogs.value.filter((blog) => blog.id != id);
};

const updating = (id: number, title: string, content: string) => {
    console.log("Inside updating");

    initModalTitle.value = title;
    initModalContent.value = content;

    updatedBlog.id = id;

    isUpdating.value = true;
};

const submitUpdate = async (id: number, title: string, content: string) => {
    updatedBlog.title = title;
    updatedBlog.content = content;

    let blogToUpdate = blogs.value.find((blog) => blog.id === id);

    if (!blogToUpdate) {
        alert("So uh... we messed up... bad.");
        return;
    }

    blogToUpdate.title = title;
    blogToUpdate.content = content;

    client.UpdateBlog(updatedBlog.id, updatedBlog);

    isUpdating.value = false;
};

const updateCancelled = () => {
    isUpdating.value = false;
}
</script>

<template>
    <!-- Container needs to wrap modal or it will make blogs off center -->
    <ul class="blogs-container">
        <Modal :title="initModalTitle" :content="initModalContent" :id="updatedBlog.id" class="z-1" v-show="isUpdating" @submit="submitUpdate" @cancel="updateCancelled" />
        <li v-for="blog in blogs" :key="blog.id">
            <Blog :title="blog.title" :content="blog.content" :id="blog.id" class="blog" @isDeleted="deleteById" @isUpdating="updating" />
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
    min-width: 280px;
}

li {
    list-style-type: none;

    display: flex;
    justify-content: center;
}

@media only screen and (max-width: 774px) {
    .blogs-container {
        display: flex;
        align-items: center;
        flex-direction: column;
        flex-flow: row;
        flex-wrap: wrap;
        gap: 0.5em;

        min-height: 86vh;
        width: 100vw;
        overflow-y: scroll;

        padding: 0;
        margin: 0;

        z-index: auto;
    }
}

@media only screen and (max-width: 707px) {
    .blog {
        margin: 0.25em 0;
        width: 90vw;
    }
}
</style>
