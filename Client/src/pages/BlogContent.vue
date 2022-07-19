<script setup lang="ts">
    import Blog from "../components/Blog.vue";
</script>

<template>
    <div class="blogs-container">
        <Blog class="blog" title="test" content="this is a blog with text"/>
        <Blog class="blog" title="test" content="this is a blog with text"/>
        <Blog class="blog" title="test" content="this is a blog with text"/>
        <Blog class="blog" title="test" content="this is a blog with text"/>
        <Blog class="blog" title="test" content="this is a blog with text"/>
    </div>
</template>

<style scoped>
    .blogs-container {
        border: 1px solid pink;
        
        display: flex;
        align-items: center;
        flex-direction: column;

        max-height: 86vh;
        overflow-y: scroll;
    }

    .blog {
        margin: 2em 0;
    }
</style>