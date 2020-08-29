<template>
  <main id="number-converter">
    <number-submit-form />
  </main>
</template>

<script>
import NumberSubmitForm from './components/NumberSubmitForm.vue';

export default {
  name: 'number-converter',
  components: {
    NumberSubmitForm
  }
}
</script>

<style>

body {
   height: 100vh;
   width: 100vw;
   background-image: url('./assets/purple-ship.jpg');
   background-color: black;
   display: flex;
   align-content: center;
}

#number-converter {
    width: 70%;
    height: 50%;
    margin: auto;
    text-align: center;
}
</style>
