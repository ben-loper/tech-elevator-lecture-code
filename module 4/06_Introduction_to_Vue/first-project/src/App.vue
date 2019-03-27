<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png">
    <!-- <hello-world msg="Welcome me"/> -->
    <fun-time name="Chris Rupp" phone="513-555-5555"/>
    <fun-time name="Blake Maislyn" phone="444-444-444"/>
    <fun-time />
  </div>
</template>

<script>
// import HelloWorld from './components/HelloWorld.vue'
import FunTime from './components/FunTime.vue'

export default {
  name: 'app',
  components: {
    // HelloWorld,
    FunTime
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
