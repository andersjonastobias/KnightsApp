window.graphic = {
    renderBitmap: function (canvasId, width, height, pixels) {
        const canvas = document.getElementById(canvasId);
        const ctx = canvas.getContext("2d");
        const imageData = new ImageData(
            new Uint8ClampedArray(pixels),
            width,
            height);
        ctx.putImageData(imageData, 0, 0);
    }
};