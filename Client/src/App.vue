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
/* .blog-content {
    position: fixed;
    top: 5vh;
    max-height: 90vh;
    min-height: 400px;
    left: 0;

    width: 100vw;

    overflow-y: scroll;
} */

.container {
    position: fixed;
    left: 0;
    top: 0;
    
    display: flex;
    flex-direction: column;

    overflow-y: scroll;

    max-height: 100vh;
}
</style>
