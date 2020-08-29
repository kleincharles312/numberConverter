import { expect } from 'chai'
import { shallowMount } from '@vue/test-utils'

import binary from './src/services/BinaryConverter.js';

describe('Binary Happy Path', () => {
    describe('Returns correct for positive integers', () => {
        it('should return "1" when 1 is passed in', () => {
            assert.equal(binary.convertDecimalToBinary(1), '1');
        });
    })
});

var assert = require('assert');
describe('Array', function () {
  describe('#indexOf()', function () {
    it('should return -1 when the value is not present', function () {
      assert.equal([1, 2, 3].indexOf(4), -1);
    });
  });
});
