import Vue from 'vue'
import NumberConverter from './NumberConverter.vue'

Vue.config.productionTip = false

new Vue({
  render: h => h(NumberConverter),
}).$mount('#number-converter')
