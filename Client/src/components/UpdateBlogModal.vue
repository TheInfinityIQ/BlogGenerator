<script setup lang="ts">    
    const { id, title, content } = defineProps<{
        id: number;
        title: string;
        content: string;
    }>();
    </script>
    
    <template>
        <div class="modal-overlay">
            <article class="modal">
                <!-- Title slot. Can be prop -->
                <h6>Update</h6>
                <!-- Form slot  -->
                <div class="rows">
                    <div class="row">
                        <label for="title">Title</label>
                        <input type="text" id="title" v-model="title" />
                    </div>
                    <div class="row">
                        <label for="content">Content</label>
                        <textarea id="content" cols="30" rows="10" v-model="content"></textarea>
                    </div>
                    <button @click="$emit('submit', id, title, content)">Submit</button>
                    <button @click="$emit('cancel')">Cancel</button>
                </div>
            </article>
        </div>
    </template>
    
    <style>
    textarea {
        resize: none;
    }
    
    .modal-overlay {
        position: fixed;
        top: 0;
        bottom: 0;
        left: 0;
        right: 0;
    
        display: flex;
        justify-content: center;
        align-items: center;
    
        background-color: #000000da;
    
        z-index: 999;
    }
    
    .modal {
        text-align: center;
        background-color: white;
    
        max-height: 500px;
    
        width: 80vw;
        max-width: 500px;
        min-width: 250px;
    
        border-radius: 20px;
    
        display: flex;
        flex-direction: column;
        align-items: center;
    
        padding: 2em 0;
    }
    
    .rows {
        width: 80%;
    }
    
    .row {
        display: flex;
        flex-direction: column;
    
        margin: 1em 0;
    }
    
    label {
        text-align: start;
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
        background-color: hsl(210, 29%, 24%);
        color: white;
    
        width: 8em;
        height: 3em;
    
        border-radius: 16px;
    
        margin: 0.25em;
    }
    
    button:hover {
        background-color: hsl(210, 39%, 39%);
    }
    button:active {
        background-color: hsl(210, 19%, 19%);
    }
    </style>
    