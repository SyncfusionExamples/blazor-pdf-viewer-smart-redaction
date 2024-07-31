function created() {
    document.getElementById('pdfviewer_open').addEventListener('click', function () {
        document.querySelector('.e-upload-browse-btn').click()
    })
}
function isMobileDevice(isRtl) {
    //Check if the device is mobile
    var isMobile = this.sfBlazor.isDevice(isRtl)
    var sampleContent = document.querySelector('.sample-content')
    if (isMobile) {
        var sampleContentRect = sampleContent.getBoundingClientRect();
        var sampleContentMinWidth = 425;
        if (sampleContentRect && ((sampleContentRect.width) > sampleContentMinWidth)) {
            return false;
        } else {
            return true;
        }
    }
    return isMobile;
}
function checkClickedDiv() {
    //Check the clicked div is the child of ViewerContainer
    var activeElement = document.activeElement;
    var viewerContainer = document.querySelector('.e-pv-viewer-container');
    return viewerContainer.contains(activeElement);
}