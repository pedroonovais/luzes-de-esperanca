module.exports = {
    content: [
        "./**/*.{html,js,razor}"
    ],
    theme: {
        extend: {
            colors: {
                primary: "var(--color-primary)",
                "primary-dark": "var(--color-primary-dark)",

                "background-light": "var(--color-background-light)",
                "background-dark": "var(--color-background-dark)",

                "text-main": "var(--color-text-main)",
                "text-secondary": "var(--color-text-secondary)",
            },

            fontFamily: {
                display: ["var(--font-public-sans)"],
                body: ["var(--font-public-sans)"],
            },

            borderRadius: {
                DEFAULT: "var(--radius)",
                lg: "var(--radius-lg)",
                xl: "var(--radius-xl)",
                full: "var(--radius-full)",
            },
        },
    },
    plugins: [],
}