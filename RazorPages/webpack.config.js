const path = require("path")

module.exports = {
    entry: {
        bundle: "./scripts/main.js"
    },

    output: {
        filename: "[name].js",
        path: path.resolve(__dirname, "wwwroot/js")
    },

    mode: "production",
    devtool: "source-map",

    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: [
                    /node_modules/
                ],
                use: [
                    { loader: "babel-loader" }
                ]
            }
        ]
    }
}