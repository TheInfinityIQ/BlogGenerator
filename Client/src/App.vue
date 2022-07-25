<script setup lang="ts">
import NavBar from "./components/NavBar.vue";
import BlogContent from "./pages/BlogContent.vue";
import Footer from "./components/Footer.vue";
</script>

<template>
    <div class="container">
        <NavBar />
        <BlogContent class="blog-content" />
        <Footer />
    </div>
</template>

<style scoped>
.container {
    position: fixed;
    left: 0;
    top: 0;

    display: flex;
    flex-direction: column;

    overflow-y: scroll;

    max-height: 100vh;
}

header,
footer {
    height: 7vh;
    min-height: 80px;
    width: 100vw;

    padding: 0 10%;

    border: 1px solid black;
}
</style>
