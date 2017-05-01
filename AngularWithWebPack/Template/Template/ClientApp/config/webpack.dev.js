﻿const path = require('path');
const webpackMerge = require('webpack-merge');
const ExtractTextPlugin = require('extract-text-webpack-plugin');
const commonConfig = require('./webpack.common.js');
const helpers = require('./helpers');

const ROOT = 'wwwroot';

const devConfig = {
    devtool: 'cheap-module-eval-source-map',

    output: {
        path: helpers.root(`../${ROOT}/dist`), //Copies the dist folder to the wwwroot hosted folder
        publicPath: '/',
        filename: '[name].js',
        chunkFilename: '[id].chunk.js'
    },

    plugins: [
        new ExtractTextPlugin('[name].css')
    ],

    devServer: {
        historyApiFallback: true,
        stats: 'minimal',
        contentBase: path.join(__dirname, `/${ROOT}/`),
        watchOptions: {
            aggregateTimeout: 300,
            poll: 1000
        }
    }
};

module.exports = webpackMerge(commonConfig, devConfig);