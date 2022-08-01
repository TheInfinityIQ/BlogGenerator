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
        <Nav-Bar />
        <Suspense>
            <Blog-Content class="blog-content" />
        </Suspense>
        <Basic-Footer />
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

    max-height: 100vh;
    width: 100vw;
}

.blog-content {
    display: flex;
    justify-content: center;
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
