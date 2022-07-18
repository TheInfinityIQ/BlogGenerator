<script setup lang="ts">
import { RouterLink } from "vue-router";

let { path } = defineProps<{
    path: string;
}>();
</script>

<template>
    <router-link :to="path" />
</template>

<style scoped>
div {
    background-color: black;
}

p {
    color: white;
}
</style>
