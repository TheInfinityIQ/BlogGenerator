<script setup lang="ts">
import NavBar from "./components/NavBar.vue";
import BlogContent from "./pages/BlogContent.vue";
import BasicFooter from "./components/FooterComp.vue";
import Test from "./pages/Test.vue";
import client from "./api";
import type { Blog } from "./models";
</script>

<template>
    <div class="container">
        <Nav-Bar class="marginals"/>
        <Suspense>
            <Blog-Content class="blog-content" />
        </Suspense>
        <Basic-Footer class="marginals"/>
    </div>
    <!-- <Test /> -->
</template>

<style scoped>
.container {
    position: fixed;
    left: 0;
    top: 0;

    display: flex;
    flex-direction: column;
    align-items: center;

    height: 100vh;
    width: 100vw;
}

.blog-content {
    display: flex;
    justify-content: center;
}
</style>

<!-- General Styles -->
<style>
h1, h2, h3, h4, h5 {
    font-family: "Zilla Slab", serif;
}

p {
    font-family: 'Inter', sans-serif;
}
</style>
