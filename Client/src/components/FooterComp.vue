<script setup lang="ts"></script>

<template>
    <footer>
        <p>Project Made by Dawson Kelly. Using .Net and Vue3</p>
    </footer>
</template>

<style scoped>
footer {
    height: 7vh;
    min-height: 80px;
    width: 100vw;

    border: 1px solid black;

    display: flex;
    align-items: center;
    justify-content: start;

    padding-left: 3em;
}

@media only screen and (max-height: 1259px) {
    footer {
        display: none;
    }
}
</style>
