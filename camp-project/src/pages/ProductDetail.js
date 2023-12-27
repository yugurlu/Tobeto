import React, { useState, useEffect }  from 'react'
import { useParams } from 'react-router-dom'
import { Button, Card, Image } from 'semantic-ui-react'
import ProductService from '../services/productService'

export default function ProductDetail() {
    let { id } = useParams();

    const [category, setcategory] = useState({})

  useEffect(() => {
    let productService = new ProductService()
    productService.getByCategoryId(id).then(result => 
        setcategory(result.data.data))
    }, [])   

    return (
        <div>
            <Card.Group>
                <Card fluid>
                    <Card.Content>
                        <Image
                            floated='right'
                            size='mini'
                            src='https://antasya.com/wp-content/uploads/2021/09/blog4.jpg'
                        />
                        <Card.Header>{category.id}</Card.Header>
                        <Card.Meta>{category.name}</Card.Meta>
                    </Card.Content>
                    <Card.Content extra>
                        <div className='ui two buttons'>
                            <Button basic color='green'>
                                Approve
                            </Button>
                            <Button basic color='red'>
                                Decline
                            </Button>
                        </div>
                    </Card.Content>
                </Card>
            </Card.Group>
        </div>
    )
}


