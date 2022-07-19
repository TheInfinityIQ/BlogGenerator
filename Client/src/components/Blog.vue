<script setup lang="ts">
    const { title, content } = defineProps<{
        title: string;
        content: string;
    }>()
</script>

<template>
    <div class="blog-container">
        <h3>{{ title }}</h3>
        <p>{{ content }}</p>
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

        padding: 2em;

        overflow-y: scroll;
    }

    h3 {

    }

    p {

    }
</style>
