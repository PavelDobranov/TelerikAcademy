/*
Create a function that takes an id or DOM element and an array of contents

* If an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight 'string' or 'number'
    * In that case, the content of the element must not be changed
*/

module.exports = function () {
  'use strict';

  function isString(item) {
    return typeof item === 'string';
  }

  function isNumber(item) {
    return typeof item === 'number';
  }

  function isArray(item) {
    return Array.isArray(item);
  }

  function isValidHtmlElement(element) {
    return element instanceof HTMLElement;
  }

  function collectionContainsOnlyStringsAndNumbers(collection) {
    return collection.every(function (item) {
      return isString(item) || isNumber(item);
    });
  }

  function removeDomElementContent(element) {
    element.innerHTML = '';
  }

  return function (element, contents) {
    var domElement,
      divElement,
      fragment,
      contentElement;

    if (!isString(element) && !isValidHtmlElement(element)) {
      throw new Error('Provide id or existing DOM element as first parameter!');
    }

    if (!isArray(contents)) {
      throw new Error('Provide array as second parameter!');
    }

    if (!collectionContainsOnlyStringsAndNumbers(contents)) {
      throw new Error('Array of contents must contain only strings or numbers!');
    }

    if (isString(element)) {
      domElement = document.getElementById(element);

      if (!domElement) {
        throw new Error('There is no element that has an id: ' + element);
      }
    } else {
      domElement = element;
    }

    removeDomElementContent(domElement);

    divElement = document.createElement('div');
    fragment = document.createDocumentFragment();

    contents.forEach(function (content) {
      contentElement = divElement.cloneNode(true);
      contentElement.innerHTML = content;
      fragment.appendChild(contentElement);
    });

    domElement.appendChild(fragment);
  };
};