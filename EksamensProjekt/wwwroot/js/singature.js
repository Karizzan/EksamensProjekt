window.saveAsFile = function (filename, bytesBase64) {
    const link = document.createElement('a');
    link.href = 'data:application/pdf;base64,' + bytesBase64;
    link.download = filename;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
};
