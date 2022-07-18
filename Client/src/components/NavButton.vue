<script setup lang="ts">
import { RouterLink } from "vue-router";

let { path, title } = defineProps<{
    path: string;
    title: string;
}>();
</script>

<template>
    <router-link :to="path">{{ title }}</router-link>
</template>

<style scoped>
router-link {
    background-color: black;
    width: 100px;
    height: 10px;
}

p {
    color: white;
}
</style>
