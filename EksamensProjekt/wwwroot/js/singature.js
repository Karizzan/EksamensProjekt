window.getSignatureImage = (canvasId) => {
    console.log("getSignatureImage called with canvasId: " + canvasId);
    var canvas = document.getElementById(canvasId).querySelector("canvas");
    if (canvas) {
        console.log("Canvas found, returning data URL");
        return canvas.toDataURL();
    }
    console.log("Canvas not found");
    return null;
};
