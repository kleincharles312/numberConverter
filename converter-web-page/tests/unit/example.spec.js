import { expect } from 'chai'
// import { shallowMount } from '@vue/test-utils'

describe('TestWorks', () => {
  it('Heading should be "Convert"', () => {
    const mainHeading = document.querySelector('#converter-app h1')
    expect(mainHeading.innerText).to.be('Convert')
  })
})
