<script setup lang="ts">
import client from "../api";
import type { Blog } from "@/models.js";

let blogToAdd: Blog = {
    id: 0,
    title: "AddedBlog",
    content: "Content",
};

let response = client.AddBlog(blogToAdd);
console.log(response);

let response2 = client.AddBlog(blogToAdd);
console.log(response2);

let response3 = client.AddBlog(blogToAdd);
console.log(response3);
</script>
