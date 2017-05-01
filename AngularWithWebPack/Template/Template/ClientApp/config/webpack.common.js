const path = require('path');
const webpack = require('webpack');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const ExtractTextPlugin = require('extract-text-webpack-plugin');
const helpers = require('./helpers');

const SRC = 'src';
const CLIENT_DIR = `ClientApp/${SRC}`;

const POLYFILLS = 'polyfills';
const VENDOR = 'vendor';
const MAIN = 'main';
const APP = 'app';
const INDEX = 'index.html';

const PATHS = {
    src: path.join(__dirname, `../${SRC}`)
};

module.exports = {
    entry: {
        'polyfills': path.join(PATHS.src, `${POLYFILLS}.ts`), //Browser Compatability/Fallback functionality
        'vendor': path.join(PATHS.src, `${VENDOR}.ts`), //Third party Libraries
        'app': path.join(PATHS.src, `${MAIN}.ts`) //This Application
    },
    resolve: {
        extensions: ['.ts', '.js']
    },
    module: {
        rules: [
            {
                test: /\.ts$/,
                loaders: [
                    {
                        loader: 'awesome-typescript-loader',
                        options: { configFileName: helpers.root(SRC, 'tsconfig.json') }
                    },
                    'angular2-template-loader'
                ]
            },
            {
                test: /\.html$/,
                loader: 'html-loader'
            },
            {
                test: /\.(png|jpe?g|gif|svg|woff|woff2|ttf|eot|ico)$/,
                loader: 'file-loader?name=assets/[name].[hash].[ext]'
            },
            {
                test: /\.scss$/,
                include: helpers.root(CLIENT_DIR, APP),
                loader: 'raw-loader'
            },
            {
                test: /\.scss$/,
                exclude: helpers.root(CLIENT_DIR, APP),
                loader: ExtractTextPlugin.extract({
                    fallback: 'style-loader',
                    loader: ['css-loader', 'sass-loader']
                })
            }
        ]
    },
    plugins: [

        //SCSS
        new ExtractTextPlugin({
            filename: '[name].[contenthash].css',
            allChunnks: true
        }),

        //Debug mode
        new webpack.LoaderOptionsPlugin({
            debug: true
        }),

        new webpack.ContextReplacementPlugin(
            /angular(\\|\/)core(\\|\/)@angular/,
            path.resolve(__dirname, '../src')
        ),

        new webpack.ProvidePlugin({
            $: 'jquery',
            jQuery: 'jquery',
            Tether: 'tether'
        }), // Maps these identifiers to the jQuery package (because Bootstrap expects it to be a global variable)
        new webpack.IgnorePlugin(/^vertx$/), // Workaround for https://github.com/stefanpenner/es6-promise/issues/100
        new webpack.optimize.CommonsChunkPlugin({
            name: [APP, VENDOR, POLYFILLS]
        }),

        new HtmlWebpackPlugin({
            inject: true,
            filename: `../${INDEX}`,
            template: `${PATHS.src}/${INDEX}`
        })
    ]
};