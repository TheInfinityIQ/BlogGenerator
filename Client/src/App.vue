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
    color: dimgray;
}

button {
    margin-right: 2em;

    border-radius: 5px;
    border: none;

    background-color: rgb(105, 105, 105);
    color: white;

    padding: 0.33em;

    font-weight: 500;
    font-family: 'inter', 'Courier New', Courier, monospace;
}

button:hover {
    background-color: rgb(125, 125, 125);
}

button:active {
    background-color: rgb(85, 85, 85);
}
</style>
