$.fn.gallery = function (columns) {
    var columns = columns || 4,
        $this = $(this),
        $selected = $this.find('.selected'),
        $images = $this.find('.gallery-list img');

    $this.addClass('gallery')
    .css('width', 260 * columns);

    $selected.hide();

    $images.on('click', disableBackground);

    //$selected
    //    .find('.previous-image img')
    //    .on('click', showSelected($(this)));

    //$selected
    //    .find('.next-image img')
    //    .on('click', showSelected($(this)));

    $selected
        .find('.current-image img')
        .on('click', enableBackground);

    function disableBackground() {
        var $clickedImage = $(this);

        $clickedImage
            .parents('.gallery-list')
            .addClass('blurred')
            .addClass('disabled-background');
        showSelected($clickedImage);
    }

    function enableBackground() {
        var $target = $(this),
            $selectedDiv = $target.parent().parent();

        $selected
            .hide()
            .prev()
            .removeClass('blurred')
            .removeClass('disabled-background');
    }

    function showSelected($caller) {
        var $clickedImage = $caller,
            $currentSelectedImage = $selected.find('.current-image img'),
            $previousSelectedImage = $selected.find('.previous-image img'),
            $nextSelectedImage = $selected.find('.next-image img'),
            $previousImage = $clickedImage.parent().prev().find('img'),
            $nextImage = $clickedImage.parent().next().find('img');


        $clickedImage
            .parents('.gallery-list')
            .addClass('blurred')
            .addClass('disabled-background');

        $currentSelectedImage.attr('src', $clickedImage.attr('src'));
        $previousSelectedImage.attr('src', $previousImage.attr('src'));
        $nextSelectedImage.attr('src', $nextImage.attr('src'));
        $selected.show();
    }
};