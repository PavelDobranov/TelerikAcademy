function solve() {
  return function (selector) {
    var $this = $(selector).hide(),
      $options = $this.children('option');

    var $wrapper = $('<div />')
      .addClass('dropdown-list');

    var $current = $('<div />')
      .addClass('current')
      .html($options.first().html())
      .val($options.first().attr('data-value'))
      .appendTo($wrapper);

    var $optionsContainer = $('<div />')
      .addClass('options-container')
      .hide()
      .appendTo($wrapper);

    $options.each(function (index, option) {
      var $option = $(option)
      $('<div />')
        .addClass('dropdown-item')
        .attr({
          'data-value': $option.attr('value'),
          'data-index': index
        })
        .html($option.html())
        .appendTo($optionsContainer);
    });

    $this.before($wrapper);
    $wrapper.prepend($this);

    $current.on('click', function () {
      $optionsContainer.toggle();
    });

    $optionsContainer.on('click', '.dropdown-item', function () {
      var $option = $(this);
      $optionsContainer.hide();
      $current.html($option.html());
      $this.val($option.attr('data-value'));
    });
  };
}

module.exports = solve;