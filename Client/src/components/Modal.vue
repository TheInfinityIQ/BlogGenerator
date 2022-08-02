<script setup lang="ts">
    const { title, content } = defineProps<{
        title: string;
        content: string;
    }>();
</script>

<template>
    <div class="modal-container">
        <label for="title">Title</label>
        <input type="text" id="title" :value="title">
        <label for="content">Content</label>
        <textarea name="content" id="content">{{ content }}</textarea>      
    </div>
</template>

<style scoped>
    
</style>