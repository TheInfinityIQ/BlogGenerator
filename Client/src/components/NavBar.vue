<script setup lang="ts">
import NavButton from "./NavButton.vue";
</script>

<template>
    <header>
        <h1>BlogGenerator</h1>
        <nav>
            <NavButton class="inline-block" path="/" title="PathOne" />
            <NavButton class="inline-block" path="/" title="PathTwo" />
        </nav>
    </header>
</template>

<style scoped>
.inline-block {
    display: inline-block;
    
    min-width: 100px;
    width: 10%;
}

header {
    height: 7vh;
    min-height: 80px;
    width: 100vw;

    padding: 0 10%;

    border: 1px solid black;
}
</style>
