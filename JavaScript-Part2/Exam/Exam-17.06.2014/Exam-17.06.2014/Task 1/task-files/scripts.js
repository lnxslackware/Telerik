function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector),
        images = items,
        imageTemplate = document.createElement("img"),
        divTemplate = document.createElement("div"),
        fragment = document.createDocumentFragment(),
        titleTemplate = document.createElement("p"),
        imageTitleTemplate = document.createElement("strong"),
        previewImageBox = document.getElementsByClassName('preview');
    IMAGES_WIDTH = 150;

    container.style.border = '1px solid red';
    container.style.display = "inline-block";
    container.style.width = "800px";
    container.style.height = "500px";

    //text align
    titleTemplate.style.textAlign = 'center';
    imageTitleTemplate.style.textAlign = 'center';

    //large preview box
    function createPreviewBox() {
        var previewDiv = divTemplate.cloneNode(true),
            previewImage = imageTemplate.cloneNode(true),
            previewTitleBox = previewDiv.cloneNode(true),
            titleContainer = titleTemplate.cloneNode(true),
            title = imageTitleTemplate.cloneNode(true);

        title.innerHTML = items[0].title;
        title.style.fontSize = '2em';
        titleContainer.appendChild(title);
        previewTitleBox.appendChild(titleContainer);
        previewDiv.appendChild(previewTitleBox);

        previewImage.width = 3 * IMAGES_WIDTH;
        previewImage.src = items[0].url;
        previewImage.style.borderRadius = '15px';
        previewDiv.appendChild(previewImage);
        previewDiv.style.float = 'left';
        previewDiv.style.marginLeft = "50px";
        previewDiv.className = 'preview';

        fragment.appendChild(previewDiv);
    }

    //var thumbnailStyle = imageTemplate.style;
    imageTemplate.width = IMAGES_WIDTH;

    function createPreviewList() {
        var scroller = document.createElement("div"),
        imageContainer = scroller.cloneNode(true),
        filterInput = document.createElement("input"),
        filterTitle = titleTemplate.cloneNode(true),
        filterHolder = scroller.cloneNode(true);

        scroller.className = 'scroller';

        //list container
        scroller.style.width = IMAGES_WIDTH + 10;
        scroller.style.height = '100%';
        scroller.style.overflowY = 'scroll';
        scroller.style.display = 'inline-block';
        scroller.style.float = "right";

        //filter box
        filterInput.setAttribute('type', 'text');
        filterTitle.innerHTML = 'Filter';
        filterHolder.appendChild(filterTitle);
        filterHolder.appendChild(filterInput)
        scroller.appendChild(filterHolder);
        //TODO: add event for searching


        for (var i = 0; i < images.length; i++) {
            var generatedImage = imageTemplate.cloneNode(true),
                currentDiv = imageContainer.cloneNode(true),
                currentTitletag = imageTitleTemplate.cloneNode(true),
                currentTitleHolder = titleTemplate.cloneNode(true);

            //image title
            currentTitletag.innerHTML = items[i].title;
            currentTitleHolder.appendChild(currentTitletag)
            currentDiv.appendChild(currentTitleHolder);

            //image
            generatedImage.src = items[i].url;
            generatedImage.style.borderRadius = '5px';

            //mouseOver event
            generatedImage.addEventListener('mouseover', onImageMouseOver);
            generatedImage.addEventListener('mouseout', onImageMouseOut);
            generatedImage.addEventListener('click', onImageClick);

            currentDiv.appendChild(generatedImage);

            scroller.appendChild(currentDiv);
        }

        fragment.appendChild(scroller);
    }

    function onImageClick(ev) {
        var sourceImage = ev.target.src;
        previewImageBox[0].lastChild.src = sourceImage;
    }

    function onImageMouseOver(ev) {
        ev.target.parentNode.style.background = "gray";
    }

    function onImageMouseOut(ev) {
        ev.target.parentNode.style.background = "white";
    }

    function onSearchKeywordKeyup(ev) {
        //var value,
        //    countries;
        //value = ev.target.value.toLowerCase();
        ////$countries = $('.country-item');
        //scroller = document.getElementsByClassName('scroller');
        //displ
        //if (value === '') {
        //    $countries.show();
        //} else {
        //    while (scroller.) {

        //    }
        //}
    }

    createPreviewBox();
    createPreviewList();
    container.appendChild(fragment);
}