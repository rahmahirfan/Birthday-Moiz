<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<title>Pixel Cake Animation</title>

<style>
    html, body {
        margin: 0;
        padding: 0;
        width: 100%;
        height: 100%;
        background: white;
        overflow: hidden;
        display: flex;
        align-items: center;
        justify-content: center;
        font-family: sans-serif;
    }

    .scene {
        position: relative;
        width: 100%;
        height: 100%;
    }

    /* Pixel-perfect rendering */
    img {
        image-rendering: pixelated;
        image-rendering: crisp-edges;
        user-select: none;
        pointer-events: none;
    }

    /* Cake */
    .cake {
        position: absolute;
        left: 50%;
        top: 50%;
        transform: translate(-50%, -50%);
        animation: bounce 2s ease-in-out infinite;
    }

    /* Balloons */
    .balloons {
        position: absolute;
        right: 8%;
        top: 50%;
        transform: translateY(-50%);
        animation: bounce 2.4s ease-in-out infinite;
    }

    /* Gentle bounce animation */
    @keyframes bounce {
        0%   { transform: translate(-50%, -50%) translateY(0); }
        50%  { transform: translate(-50%, -50%) translateY(-10px); }
        100% { transform: translate(-50%, -50%) translateY(0); }
    }

    /* Fix transform override for balloons */
    .balloons {
        animation-name: balloonBounce;
    }

    @keyframes balloonBounce {
        0%   { transform: translateY(-50%) translateY(0); }
        50%  { transform: translateY(-50%) translateY(-12px); }
        100% { transform: translateY(-50%) translateY(0); }
    }
</style>
</head>

<body>
    <div class="scene">
        <img src="cake.png" alt="Pixel Cake" class="cake">
        <img src="balloons.png" alt="Pixel Balloons" class="balloons">
    </div>
</body>
</html>
