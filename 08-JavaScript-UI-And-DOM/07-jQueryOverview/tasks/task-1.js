/// <reference path="../typings/jquery/jquery.d.ts"/>
/* globals $*/

/*
Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:
* The UL must have a class 'items-list'
* Each of the LIs must:
  * have a class 'list-item'
  * content "List item #INDEX"
    * The indices are zero-based
* If the provided selector does not selects anything, do nothing
* Throws if
  * COUNT is a 'Number', but is less than 1
  * COUNT is **missing**, or **not convertible** to 'Number'
    * _Example:_
      * Valid COUNT values:
        * 1, 2, 3, '1', '4', '1123'
      * Invalid COUNT values:
        * '123px' 'John', {}, []
*/

function solve() {
  return function (selector, count) {
    var $root = $(selector),
      $ul,
      $li,
      index;

    if (!selector) {
      throw new Error('Selector cannot be null or undefined!');
    }

    if (typeof selector !== 'string') {
      throw new Error('Selector must be a string!');
    }

    if (!$.isNumeric(count)) {
      throw new Error('Count must be a number!');
    }

    if (count <= 0) {
      throw new Error('Count cannot be less or equal to 0!');
    }

    if (!$root.length) {
      return;
    }

    $ul = $('<ul/>').addClass('items-list');
    $li = $('<li/>').addClass('list-item');

    for (index = 0; index < count; index++) {
      $li.clone().text('List item #' + index).appendTo($ul);
    }

    $ul.appendTo(selector);
  };
}

module.exports = solve;