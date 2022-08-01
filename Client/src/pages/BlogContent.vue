<script setup lang="ts">
import Blog from "../components/Blog.vue";
</script>

<template>
    <div class="blogs-container">
        <Suspense>
            <template #default>
                <Blog class="blog" title="test" content="this is a blog with text" />
            </template>
            <template #fallback>
                <span>Loading...</span>
            </template>
        </Suspense>
    </div>
</template>

<style scoped>
.blogs-container {
    border: 1px solid pink;

    display: flex;
    align-items: center;
    flex-direction: column;

    height: 86vh;
    /* min-height: 86vh; */
    overflow-y: scroll;
}

.blog {
    margin: 2em 0;
}
</style>
