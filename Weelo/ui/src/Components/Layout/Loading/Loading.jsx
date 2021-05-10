import React from 'react';
import LoadingBar from 'react-top-loading-bar'

const Loading = ({progress}) => {
        return (            
            <LoadingBar
              color='#f11946'
              progress={progress}              
            />
        )
}
 
export default Loading;