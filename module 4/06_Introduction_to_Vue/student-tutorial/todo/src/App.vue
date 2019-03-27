<template>
  <div id="todo-app">
    <product-review msg="Howdy Y'all" />
    <product-review msg="!Howdy Y'all" />
  </div>
</template>

<script>
import ProductReview from './components/ProductReview.vue'

export default {
  name: 'app',
  components: {
    ProductReview
  }
}
</script>

<style>
body {
background: rgb(74,162,244);
background: radial-gradient(circle, rgba(74,162,244,1) 0%, rgba(54,131,240,1) 100%);}
</style>
