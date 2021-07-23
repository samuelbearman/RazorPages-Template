module.exports = {
    purge: {
        enabled: false,
        content: [
            './Pages/**/*.cshtml',
            './Views/**/*.chstml'
        ]
    },
    darkMode: false, // or 'media' or 'class'
    theme: {
        extend: {},
    },
    variants: {
        extend: {},
    },
    plugins: [
        require('@tailwindcss/forms'),
        require('@tailwindcss/typography')
    ]
}
