var tee = $('.gridtable thead');
var tw = document.getElementsByClassName('table-responsive')[0];
var cloner = document.getElementsByClassName('table-responsive')[0];
var bd = document.getElementsByClassName('grid')[0];
var newTableWrap = document.createElement("div");
var newTable = document.createElement("Table");
var oldTable = document.getElementsByClassName('gridtable')[0];
var childNode = oldTable.childNodes[1];
var wrapW = $(tw).css('width');
var wrapY = $(tw).css('height');
var headHeight = tee.css('height');

//node The node to be cloned.
var dupNode = childNode.cloneNode(true);
newTable.appendChild(dupNode);
newTableWrap.appendChild(newTable);

newTable.classList.add("gridtableT");
newTable.classList.add("gridtable");
$(newTableWrap).css({ 'width': '100%', 'background-color': '#ededed', 'overflow': 'hidden' });

bd.insertBefore(newTableWrap, tw);
$(oldTable).css('margin-top', ('-' + headHeight));

$(tw).on('scroll', function (e) {
    var newLeft = e.target.scrollLeft;
    $(newTable).css('margin-left', '-' + newLeft + 'px');
});