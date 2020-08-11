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
    display:grid;
    grid-template-columns: 100px 1fr 1fr 100px;
    grid-template-rows: 100px 1fr 1fr 100px;
    grid-template-areas: 
        ". . . ."
        ". main main ."
        ". main main ."
        ". . . ."
    ;
}

#number-converter {
    grid-area: main;
    height: 100%;
    width: 100%;
    text-align: center;
}
</style>
