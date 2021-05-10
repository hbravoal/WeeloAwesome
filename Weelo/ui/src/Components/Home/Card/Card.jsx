import React from 'react';
import {useHistory} from 'react-router-dom';




const Card = ({item}) => {
    const history = useHistory();

    const handleProductDetail=(itemGuid) => {
        history.push(`Property/${itemGuid}`)
    }
    return ( 
        <div className="col-6 px-1 px-md-3 col-md-4" data-numb="0" >
            <div className="awards-card">
                <div className="img"> <img className="w-100" src={item.photo ?? 'https://upload.wikimedia.org/wikipedia/commons/2/2f/No-photo-m.png'}  alt={item.name} /></div>
                <div className="text text-center pt-3">
                <h2 className="color-bluelight title">{item.name} </h2>
                <p>{item.address} </p>
                </div>
                <a className="more" href="Detail" onClick={(e)=>{e.preventDefault();handleProductDetail(item.id)}}  >Detail</a>
            </div>
        </div>

     );
}
 
export default Card;