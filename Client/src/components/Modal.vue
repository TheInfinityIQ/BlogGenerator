<script setup lang="ts">
const { title, content } = defineProps<{
    title: string;
    content: string;
}>();
</script>

<template>
    <div class="modal-overlay">
        <article class="modal">
            <h6>Update</h6>
            <div class="rows">
                <div class="row">
                    <label for="title">Title</label>
                    <input type="text" id="title">
                </div>
                <div class="row">
                    <label for="content">Content</label>
                    <textarea id="content" cols="30" rows="10"></textarea>
                </div>
            </div>
            <button @click="">Confirm Update</button>
        </article>
    </div>
</template>

<style scoped>
.modal-overlay {
  position: fixed;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  display: flex;
  justify-content: center;
  background-color: #000000da;
}

.modal {
  text-align: center;
  background-color: white;
  
  max-height: 500px;
    
  width: 80vw;
  max-width: 500px;
  min-width: 250px;

  margin-top: 10%;
  padding: 60px 0;
  border-radius: 20px;

  display: flex;
  flex-direction: column;
  align-items: center;
}

.rows {
    width: 80%;
}

.row {
    display: flex;
    flex-direction: column;    
}

.close {
  margin: 10% 0 0 16px;
  cursor: pointer;
}

.close-img {
  width: 25px;
}

.check {
  width: 150px;
}

h6 {
  font-weight: 500;
  font-size: 28px;
  margin: 20px 0;
}

p {
  font-size: 16px;
  margin: 20px 0;
}

button {
  background-color: #2c3e50;;
  width: 150px;
  height: 40px;
  color: white;
  font-size: 14px;
  border-radius: 16px;
  margin-top: 50px;
}
</style>
