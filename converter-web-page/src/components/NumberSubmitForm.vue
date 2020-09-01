<template>
  <form v-on:submit.prevent="" >
    <number-row :type="numberTypes[0]" :decimal="decimal" />
    <number-row :type="numberTypes[1]" :decimal="decimal" />
  </form>
</template>

<script>
import converter from '@/services/ConverterService.js'
import NumberRow from './NumberRow.vue'

export default {
  data () {
    return {
      numberTypes: converter.numberTypes,
      decimal: 0
    }
  },
  methods: {
    updateDecimal (num) {
      this.decimal = num
    }
  },
  components: {
    NumberRow
  }
}
</script>

<style>
form#enter-number {
  display: flex;
  flex-direction: column;
}
</style>
