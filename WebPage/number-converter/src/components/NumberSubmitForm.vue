<template>
  <form v-on:submit.prevent="submitForConversion()" id="enter-number">
    <label for="number-type">What kind of number do you want to convert?</label>
    <select name="number-type" id="type-selector" v-model="type" required >
      <option value="" disabled>--select type--</option>
      <option value="i">Base 10 Integer</option>
      <option value="h">Hexadecimal</option>
      <option value="b">Binary</option>
      <option value="r">Roman Numeral</option>      
    </select>

    <label for="number">Enter your number here:</label>
    <input type="text" name="number" id="number" v-model="numberToConvert" required />

    <input type="submit" value="Convert" />

  </form>
</template>

<script>
import api from '@/services/ApiService.js'

export default {
 //TODO impelemnt submitForConversion()
 //TODO add option for numbers to words
 data() {
   return {
      numberToConvert: "",
      type: "",
      returnedNumbers: null,
   }
 },
 methods: {
   submitForConversion(){
     api.getConversion(this.numberToConvert, this.type).then( r => {
       if (r.status === 200) {
         this.returnedNumbers = r.data;
         console.table(this.returnedNumbers);
         console.log(this.returnedNumbers);
       }
     }).catch( error => {
       if (error.resonse){
         console.log(error.response);
       } else if (error.request) {
         console.log(error.request) 
       } else {
         console.log("There was an error.")
       }
     });
     // TODO add error handling
   }
 },
};
</script>

<style>
form#enter-number {
    display: flex;
    flex-direction: column;
}
</style>