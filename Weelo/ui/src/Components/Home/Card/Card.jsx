import React from 'react';
import {useHistory} from 'react-router-dom';




const Card = ({item}) => {
    const history = useHistory();

    const handleProductDetail=(itemGuid) => {
        history.push(`ProductDetail/${itemGuid}`)
    }
    return ( 
        <div className="col-6 px-1 px-md-3 col-md-4" data-numb="0" >
            <div className="awards-card">
                <div className="img"> <img className="w-100" src={item.ProductImage} alt={item.Name} /></div>
                <div className="text text-center pt-3">
                <h2 className="color-bluelight title">{item.ProductName} </h2>
                <p>{item.Inventory} Unidades disponibles</p>
                </div>
                <a className="more" href="Detail" onClick={(e)=>{e.preventDefault();handleProductDetail(item.itemGuid)}}  >x</a>
            </div>
        </div>

     );
}
 
export default Card;