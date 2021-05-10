const path = require("path");

module.exports ={
  
  
  entry: path.resolve(__dirname, "src/index.js"),
  
  resolve: {
    alias: {
      Components: path.resolve(__dirname,'src','Components'),      
      Services: path.resolve(__dirname,'src','Services'),      
      assets: path.resolve(__dirname,'src','assets'),      
      Types: path.resolve(__dirname,'src','Types'),
      Reducers: path.resolve(__dirname,'src','Reducers'),
      Data: path.resolve(__dirname,'src','Data'),
  },
  
    extensions: [".js", ".jsx"]
  },

    
  module: {
    rules: [
      {
        test: /\.(js|jsx)$/,
        exclude: /node_modules/,
        use: ["babel-loader"]
      },
      {
        test:/\.css$/,
        use: ['style-loader', 'css-loader'],
      },
      {
        test: /\.(gif|png|jpe?g|svg|ttf|eot|woff|woof2|pdf)$/i,
        use: [
          'file-loader',
          {
            loader: 'image-webpack-loader',
            options: {
              bypassOnDebug: true, // webpack@1.x
              disable: true, // webpack@2.x and newer
            },
          },
        ],
      }
    ]
  }

};