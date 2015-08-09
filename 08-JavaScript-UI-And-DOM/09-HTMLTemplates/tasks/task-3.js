/// <reference path="../typings/jquery/jquery.d.ts"/>
/* global handlebars */

function solve() {
  return function () {
    $.fn.listview = function (data) {
      var $this = $(this),
        templateHtml = $("#" + $this.attr('data-template')).html(),
        template = handlebars.compile(templateHtml),
        $buffer = $('<div />');

      data.forEach(function (item) {
        $buffer.append(template(item));
      });

      $this.append($buffer.html());

      return this;
    };
  };
}

module.exports = solve;