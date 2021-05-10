const path = require("path");
const {merge} = require('webpack-merge');
const Dotenv = require('dotenv-webpack');
const common = require('./webpack.common.js');
var HtmlWebpackPlugin = require('html-webpack-plugin');
module.exports = merge(common,
  {
    plugins:[
      new Dotenv({path:'./.env'}),
      
        new HtmlWebpackPlugin({
            base:'/',
            template:path.resolve(__dirname, "index.html"),          
            title: 'Inicio - Localhost',
            // favicon : path.resolve(__dirname,'src/assets/img/favicon/favicon.ico'),
            minify:true,
            'meta': {
              'viewport': 'width=device-width, width=device-width, initial-scale=1.0',
              'theme-color': '#ffffff',
              'msapplication-TileColor': '#ffffff'
              
              
            }
        }),
        
      
    ],
    output: {
      path: path.resolve(__dirname, "dist"),
      filename: "[name].[hash].js",
      publicPath:'/'
    },
    mode:'development',
    
    devServer: {
      contentBase: path.resolve(__dirname, "dist"),
      port: 9000,      
      historyApiFallback: true 
    }
  
  }
  );