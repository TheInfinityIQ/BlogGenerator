<script setup lang="ts">
import NavButton from "./components/NavButton.vue";
</script>

<template>
    <header>
        <h1>BlogGenerator</h1>
          <nav>
            <NavButton class="inline-block" path="/" title="PathOne"/>
            <NavButton class="inline-block" path="/" title="PathTwo"/>
          </nav>
    </header>
</template>

<style scoped>
  .inline-block {
    display: inline-block;
    width: 50%;
  }

  header {
    border: 1px solid black;
    position: fixed;
    top: 0;
    left: 0;

    width: 100vw;

    padding: 0 10%;
  }
</style>
