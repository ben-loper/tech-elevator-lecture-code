<template>
  <div id="todo-app">
    <product-review msg="Howdy Y'all" />
    <product-review msg="!Howdy Y'all" />
  </div>
</template>

<script>
<<<<<<< HEAD
import TodoList from './components/TodoList';
=======
import ProductReview from './components/ProductReview.vue'
>>>>>>> 9581c93d5e30ab1ae5cd8861055cf634d2b825d9

export default {
  name: 'app',
  components: {
<<<<<<< HEAD
    TodoList
=======
    ProductReview
>>>>>>> 9581c93d5e30ab1ae5cd8861055cf634d2b825d9
  }
}
</script>

<style>
body {
background: rgb(74,162,244);
background: radial-gradient(circle, rgba(74,162,244,1) 0%, rgba(54,131,240,1) 100%);}
</style>
