<template>
  <div class="number-row">
      <label :for="type.name">{{type.name}}</label>
      <input type="text" :name="type.name" :id="type.name" :value="value" v-if="!inFocus" @focus="inFocus = true" />
      <input type="text" :name="type.name" :id="type.name" v-bind="value" @keyup="$emit('update-decimal', type.convertToDecimal(value))" v-if="inFocus" @blur="inFocus = false" />
  </div>
</template>

<script>

export default {
  // I want to be able to create a generic row that will convert to any number type depending on props passed in
  // Display should update as a number is typed in and should update in other number rows as well
  // Use find method to find correct converting method and build in types to ConverterService.js
  data () {
    return {
      inFocus: false
    }
  },
  computed: {
    display () {
      return this.type.convertFromDecimal(this.decimal)
    }
  },
  props: {
    type: Object,
    decimal: Number
  }
}
</script>

<style scoped>
.number-row {
    background-color: lightgrey;
    padding: 20px;
}
.number-row input {
    font-size: 18pt;

}
</style>
