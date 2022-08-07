<script setup lang="ts">
const { title, content, id } = defineProps<{
    title: string;
    content: string;
    id: number;
}>();
</script>

<template>
    <div class="blog-container">
        <div class="buttons">
            <button @click="$emit('isUpdating', id, title, content)">Update</button>
            <button @click="$emit('isDeleted', id)">Delete</button>
        </div>
        <h2>{{ title }}</h2>
        <p>{{ content }}</p>
    </div>
</template>

<style scoped>
.blog-container {
    width: 40vw;
    max-width: 500px;

    min-height: 350px;

    border: 1px solid black;
    border-radius: 5px;

    padding: 2em;
    
    overflow-y: scroll;

    background-color: white;
}
</style>
