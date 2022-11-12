import { Fragment } from "react";
import { Dropdown, DropdownButton } from "react-bootstrap";


const toggleItem = () => {

    return(
        <Fragment>
            <DropdownButton variant="primary" id="dropdwon-basic-button" title="View" size="sm">
                <Dropdown.Item>Hp 2020 Laptop</Dropdown.Item>
                <Dropdown.Item>Iphone XV+</Dropdown.Item>
                <Dropdown.Item>Mini Google</Dropdown.Item>
            </DropdownButton>
        </Fragment>
    );
}

export default toggleItem;