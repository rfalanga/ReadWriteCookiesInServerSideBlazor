console.log("CookieUtilities.js loaded successfully");

function WriteCookie(name, value, days) {
    var expires = "";
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        expires = "; expires=" + date.toUTCString();
    }

    // Encode the value to handle special characters
    const encodedValue = encodeURIComponent(value);
    document.cookie = name + "=" + encodedValue + expires + "; path=/; SameSite=Strict";
}

function ReadCookie(cname) {
    const name = cname + "=";
    const decodedCookie = decodeURIComponent(document.cookie);
    const cookies = decodedCookie.split(';');
    for (const cookie of cookies) {
        const trimmedCookie = cookie.trim();
        if (trimmedCookie.startsWith(name)) {
            return trimmedCookie.substring(name.length);
        }
    }
    return "";
}