import React from 'react';
import LoadingOverlay from 'react-loading-overlay';
import PropagateLoader from 'react-spinners/PropagateLoader'
const LoadingSpinner = () => {
    return (  
       <LoadingOverlay active={true} spinner={<PropagateLoader />}></LoadingOverlay>
    );
}
 
export default LoadingSpinner;