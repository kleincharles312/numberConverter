const convertingObj = {
  dict: ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'],

  /**
   * Returns character from dictionary of digits
   *
   * @param {Int} i Int between 0 and 36
   */
  getDigit (i) {
    if (i >= 0 && i <= 36) {
      return this.dict[i]
    }
  },

  /**
 * Converts a number from a base 10 integer to any other based number up to base 36
 *
 * @param {Int} num Base 10 number to convert
 * @param {Int} base Base number for converted number
 */
  convertToBaseNFromDecimal (num, base) {
    // this converts floats as if they were ints
    num = parseInt(num)
    base = parseInt(base)
    if (isNaN(num) || num === undefined) {
      return 'Invalid Format'
    } else if (num === 0) {
      return '0'
    }

    if (base < 0 || base > 36) {
      return 'Invalid base number'
    }

    let reducer = num
    let result = ''
    while (reducer !== 0) {
      result = convertingObj.getDigit(reducer % base) + result
      reducer /= base
    }

    return result
  }
}

export default {
  numberTypes: [
    {
      name: 'decimal',
      convertFromDecimal (num) {
        return num
      },
      convertToDecimal (num) {
        return num
      }
    },
    {
      name: 'bianry',
      convertFromDecimal (num) {
        return convertingObj.convertToBaseNFromDecimal(num, 2)
      },
      convertToDecimal (num) {
        // TODO:
        return 0
      }
    },
    {
      name: 'hexadecimal',
      convertFromDecimal (num) {
        return convertingObj.convertToBaseNFromDecimal(num, 16)
      },
      convertToDecimal (num) {
        // TODO:
        return 0
      }
    }
  ]
}
